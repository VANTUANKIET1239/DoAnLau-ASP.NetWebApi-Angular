/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { CRUDNewsComponent } from './CRUDNews.component';

describe('CRUDNewsComponent', () => {
  let component: CRUDNewsComponent;
  let fixture: ComponentFixture<CRUDNewsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CRUDNewsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CRUDNewsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
