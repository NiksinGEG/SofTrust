import { Component, OnInit } from '@angular/core';
import { User } from 'src/Models/user';
import { HttpService } from 'src/app/http.service';
import { Dictionary } from '../Models/theme';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  providers: [HttpService]
})

export class AppComponent implements OnInit {
  title = 'TestTask';
  user: User = new User("", "", "");
  dictionaries: Dictionary[] = [];
  receivedUser: User = new User("", "", "");

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
      (error) => console.log(error)
    )
    console.log(this.user.selectedTheme);
  }
}
