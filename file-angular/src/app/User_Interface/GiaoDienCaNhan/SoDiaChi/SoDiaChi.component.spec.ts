/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { SoDiaChiComponent } from './SoDiaChi.component';

describe('SoDiaChiComponent', () => {
  let component: SoDiaChiComponent;
  let fixture: ComponentFixture<SoDiaChiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SoDiaChiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SoDiaChiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
