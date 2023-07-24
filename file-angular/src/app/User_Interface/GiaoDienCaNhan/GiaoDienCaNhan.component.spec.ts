/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { GiaoDienCaNhanComponent } from './GiaoDienCaNhan.component';

describe('GiaoDienCaNhanComponent', () => {
  let component: GiaoDienCaNhanComponent;
  let fixture: ComponentFixture<GiaoDienCaNhanComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GiaoDienCaNhanComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GiaoDienCaNhanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
