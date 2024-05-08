import { HttpErrorResponse, HttpInterceptorFn } from "@angular/common/http";
import { inject } from "@angular/core";
import { LoginService } from "../Services/login.service";
import { Router } from "@angular/router";
import { catchError, throwError } from "rxjs";


export const tokenInterceptor: HttpInterceptorFn = (request, next) => {
    var loginService = inject(LoginService);
    var router = inject(Router);
    const token = loginService.getToken();

    console.log(request.url);

    if(token && !request.url.includes('Auth/Login'))
        {
            request = request.clone({
                headers: request.headers.set(
                    'Authorization', `Bearer ${token}`
                )
            });
        }
    
    return next(request).pipe(
        catchError((error:any) => {
            if( error instanceof HttpErrorResponse)
                {
                    if(error.status === 401)
                        {
                            localStorage.clear();
                            router.navigate(['login'])
                        }
                }
            return throwError(() => error);
        })
    )
}