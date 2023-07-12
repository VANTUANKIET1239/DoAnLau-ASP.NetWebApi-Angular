/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { ThemDiaChiPopUpComponent } from './ThemDiaChiPopUp.component';

describe('ThemDiaChiPopUpComponent', () => {
  let component: ThemDiaChiPopUpComponent;
  let fixture: ComponentFixture<ThemDiaChiPopUpComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ThemDiaChiPopUpComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ThemDiaChiPopUpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
