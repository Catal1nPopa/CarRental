import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ImageConvertService {

  constructor(private http: HttpClient) { }

  getImageFromByteArray(byteArray: number[]): Observable<string> {
    const blob = new Blob([new Uint8Array(byteArray)], { type: 'image/jpeg' });

    return new Observable<string>(observer => {
      const reader = new FileReader();
      reader.onloadend = () => {
        observer.next(reader.result as string);
        observer.complete();
      };
      reader.onerror = (error) => {
        observer.error(error);
      };
      reader.readAsDataURL(blob);
    });
  }
}
