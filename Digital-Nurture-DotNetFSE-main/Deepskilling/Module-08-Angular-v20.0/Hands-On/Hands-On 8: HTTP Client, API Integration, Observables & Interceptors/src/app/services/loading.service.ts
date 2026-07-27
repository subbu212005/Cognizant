import { Injectable, signal, computed } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoadingService {
  private loadingCount = signal<number>(0);

  // Computed state exposed to components
  readonly isLoading = computed(() => this.loadingCount() > 0);

  // Increment loading counter
  show() {
    this.loadingCount.update(count => count + 1);
  }

  // Decrement loading counter (clamp at 0)
  hide() {
    this.loadingCount.update(count => Math.max(0, count - 1));
  }
}
