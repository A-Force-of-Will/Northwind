import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CounterNComponent } from './counter-n.component';

describe('CounterNComponent', () => {
  let component: CounterNComponent;
  let fixture: ComponentFixture<CounterNComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CounterNComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CounterNComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should display a title', async(() => {
    const titleText = fixture.nativeElement.querySelector('h1').textContent;
    expect(titleText).toEqual('Counter N');
  }));

  it('should start with count 0, then increments by n where n is the users input', async(() => {
    const countElement = fixture.nativeElement.querySelector('strong');
    expect(countElement.textContent).toEqual('0');

    const customCountElement = fixture.nativeElement.querySelector('input');
    customCountElement.textContent = 2;

    const incrementButton = fixture.nativeElement.querySelector('button');
    incrementButton.click();
    fixture.detectChanges();
  }));
});
