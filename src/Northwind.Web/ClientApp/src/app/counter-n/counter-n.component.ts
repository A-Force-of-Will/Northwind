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
    //had a weird bug here, would append to eachother rather than add. Here is the fix!
    let newNumber = {
      a: Number(this.currentCount),
      b: Number(n)
    };
    
    console.log(newNumber);

    this.currentCount = newNumber.a + newNumber.b;
  }
}
