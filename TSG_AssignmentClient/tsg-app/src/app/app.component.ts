import { Component, OnInit } from '@angular/core';

import { AppService } from './app.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  images: any[] = [];

  ngOnInit() {
    this.myService.getSettings()
      .subscribe(data => {
        this.images = data;
      });
  }

  constructor(private myService: AppService) { }

}
