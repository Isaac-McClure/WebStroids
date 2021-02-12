import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  public showHighscore: boolean = false;
  public showPlay: boolean = false;
  public highscore: number = 0;
  
  constructor() { }

  ngOnInit(): void {
  }

}
