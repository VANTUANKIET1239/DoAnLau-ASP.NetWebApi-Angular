/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { DatMonComponent } from './DatMon.component';

describe('DatMonComponent', () => {
  let component: DatMonComponent;
  let fixture: ComponentFixture<DatMonComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DatMonComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DatMonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
