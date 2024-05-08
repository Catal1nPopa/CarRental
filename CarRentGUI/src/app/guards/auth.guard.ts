import { CanActivateFn, Router } from "@angular/router";
import { LoginService } from "../Services/login.service";
import { inject } from "@angular/core";

export const authGuard: CanActivateFn = (route, state) => {

    const loginService = inject(LoginService);
    const router = inject(Router);

    if(loginService && loginService.isLogged())
        {
            return true;
        }
    router.navigate(['login'])
    return false;
}