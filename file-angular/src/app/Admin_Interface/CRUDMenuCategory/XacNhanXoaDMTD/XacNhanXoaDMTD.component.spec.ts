/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { XacNhanXoaDMTDComponent } from './XacNhanXoaDMTD.component';

describe('XacNhanXoaDMTDComponent', () => {
  let component: XacNhanXoaDMTDComponent;
  let fixture: ComponentFixture<XacNhanXoaDMTDComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ XacNhanXoaDMTDComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(XacNhanXoaDMTDComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
