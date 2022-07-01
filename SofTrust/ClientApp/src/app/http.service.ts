import { Injectable } from '@angular/core'
import { HttpClient, HttpParams } from '@angular/common/http'
import { User } from 'src/Models/user'
import { Dictionary } from '../Models/theme'

@Injectable()
export class HttpService {
  constructor(private http: HttpClient) { }

  postData(user: User) {
    return this.http.post(
      'https://SofTrust.somee.com/publish/api/user' ,
      user
    )
  }

  getData() {
    return this.http.get<Dictionary[]>(
      'https://SofTrust.somee.com/publish/api/user',)
  }
}
