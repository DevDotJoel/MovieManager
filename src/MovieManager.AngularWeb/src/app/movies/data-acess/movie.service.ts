import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { MovieModel } from 'src/app/shared/ui/models/movie/movie.model';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  constructor(private http: HttpClient) { }
  getAll():Observable<MovieModel[]>{
    return this.http.get<MovieModel[]>("http://localhost:5257/api/movie")
  }
  create(movie:MovieModel):Observable<void>{
    return this.http.post<void>("http://localhost:5257/api/movie",movie)
  }
  update(movie:MovieModel):Observable<void>{
    return this.http.put<void>("http://localhost:5257/api/movie",movie)
  }
  delete(id:string):Observable<void>{
    return this.http.delete<void>(`http://localhost:5257/api/movie/${id}`,)
  }
}
