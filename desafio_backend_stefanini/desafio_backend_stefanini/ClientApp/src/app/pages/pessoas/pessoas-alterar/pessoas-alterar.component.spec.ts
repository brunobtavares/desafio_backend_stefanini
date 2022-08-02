import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PessoasAlterarComponent } from './pessoas-alterar.component';

describe('PessoasAlterarComponent', () => {
  let component: PessoasAlterarComponent;
  let fixture: ComponentFixture<PessoasAlterarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PessoasAlterarComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PessoasAlterarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
