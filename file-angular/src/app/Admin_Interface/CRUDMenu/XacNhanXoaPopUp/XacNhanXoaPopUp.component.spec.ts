/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { XacNhanXoaPopUpComponent } from './XacNhanXoaPopUp.component';

describe('XacNhanXoaPopUpComponent', () => {
  let component: XacNhanXoaPopUpComponent;
  let fixture: ComponentFixture<XacNhanXoaPopUpComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ XacNhanXoaPopUpComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(XacNhanXoaPopUpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
