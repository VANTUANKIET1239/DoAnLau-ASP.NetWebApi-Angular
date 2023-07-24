/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { ThongTinCaNhanComponent } from './ThongTinCaNhan.component';

describe('ThongTinCaNhanComponent', () => {
  let component: ThongTinCaNhanComponent;
  let fixture: ComponentFixture<ThongTinCaNhanComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ThongTinCaNhanComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ThongTinCaNhanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
