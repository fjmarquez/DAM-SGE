import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TablaAPIComponent } from './tabla-api.component';

describe('TablaAPIComponent', () => {
  let component: TablaAPIComponent;
  let fixture: ComponentFixture<TablaAPIComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TablaAPIComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TablaAPIComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
