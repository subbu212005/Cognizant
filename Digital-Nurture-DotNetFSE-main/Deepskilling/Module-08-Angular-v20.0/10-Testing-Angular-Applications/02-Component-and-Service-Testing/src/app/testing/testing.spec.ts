import { TestBed } from '@angular/core/testing';
import { TestingComponent } from './testing';

describe('TestingComponent',()=>{
 beforeEach(async()=>{
  await TestBed.configureTestingModule({imports:[TestingComponent]}).compileComponents();
 });
 it('should create',()=>{
  const fixture=TestBed.createComponent(TestingComponent);
  expect(fixture.componentInstance).toBeTruthy();
 });
});
