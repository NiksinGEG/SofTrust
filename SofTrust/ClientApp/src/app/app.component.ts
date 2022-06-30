import { Component, OnInit } from '@angular/core';
import { User } from 'src/Models/user';
import { HttpService } from 'src/app/http.service';
import { Dictionary } from '../Models/theme';
import { Message } from '@angular/compiler/src/i18n/i18n_ast';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  providers: [HttpService]
})

export class AppComponent implements OnInit {
  title = 'TestTask';
  user: User = new User("", "", "", "");
  dictionaries: Dictionary[] = [];
  receivedUser: any;

  done: boolean = false;
  constructor(private httpService: HttpService) { }

  ngOnInit() {
    this.GetThemes();
  }



  GetThemes() {
    this.httpService.getData()
      .subscribe((data: Dictionary[]) => this.dictionaries = data);
  }

  PostUser() {
    this.httpService.postData(this.user).subscribe(
      (data: any) => {
        this.receivedUser = data;
        console.log(this.receivedUser);
        this.done = true;
      },
      (error) => console.log(error)
    )

  }
}
