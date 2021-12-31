import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-counter-n',
  templateUrl: './counter-n.component.html',
  styleUrls: ['./counter-n.component.css']
})
export class CounterNComponent implements OnInit {

  public currentCount = 0;
  constructor() { }

  ngOnInit() {
  }

  public incrementCounter(n: number) {
    
    this.currentCount+= n;
  }
}
