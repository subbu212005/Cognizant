import { Component, DebugElement } from '@angular/core';
import { ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { HighlightDirective } from './highlight.directive';

@Component({
  standalone: true,
  imports: [HighlightDirective],
  template: `<div id="test-div" appHighlight>Test content</div>`
})
class TestHostComponent {}

describe('HighlightDirective', () => {
  let fixture: ComponentFixture<TestHostComponent>;
  let divEl: DebugElement;

  beforeEach(() => {
    fixture = TestBed.configureTestingModule({
      imports: [TestHostComponent, HighlightDirective]
    }).createComponent(TestHostComponent);

    fixture.detectChanges();
    divEl = fixture.debugElement.query(By.css('#test-div'));
  });

  it('should create host component', () => {
    expect(fixture.componentInstance).toBeTruthy();
  });

  it('should apply styles on mouseenter', () => {
    divEl.triggerEventHandler('mouseenter', null);
    fixture.detectChanges();

    const element = divEl.nativeElement as HTMLElement;
    expect(element.style.transform).toContain('translateY(-4px)');
    expect(element.style.boxShadow).toBeTruthy();
  });

  it('should remove styles on mouseleave', () => {
    divEl.triggerEventHandler('mouseenter', null);
    fixture.detectChanges();
    divEl.triggerEventHandler('mouseleave', null);
    fixture.detectChanges();

    const element = divEl.nativeElement as HTMLElement;
    expect(element.style.transform).toBe('');
    expect(element.style.boxShadow).toBe('');
  });
});
