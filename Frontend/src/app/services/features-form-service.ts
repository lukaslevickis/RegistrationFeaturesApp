import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { FormFeaturesModel } from '../models/formFeaturesModel';
import { FeaturesModel } from '../models/featuresModel';

@Injectable({
  providedIn: 'root'
})
export class FeaturesFormService {
  private http: HttpClient;

  constructor(http: HttpClient) {
    this.http = http;
   }

  public getForms(): Observable<FormFeaturesModel[]> {
    return this.http.get<FormFeaturesModel[]>("https://localhost:5002/api/home");
  }

  public getForm(id:string): Observable<FormFeaturesModel> {
    return this.http.get<FormFeaturesModel>(`${"https://localhost:5002/api/home"}/${id}`);
  }

  public updateForm(id: string, features: FeaturesModel): Observable<FeaturesModel> {
    return this.http.put<FeaturesModel>(`${"https://localhost:5002/api/home"}/${id}`, features);
  }
}
