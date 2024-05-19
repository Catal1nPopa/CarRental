import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filterStatePipe'
})
export class FilterStatePipePipe implements PipeTransform {

  transform(items: any[], onlyAvailable: boolean): any[] {
    if (!items) return [];
    if (!onlyAvailable) return items;

    return items.filter(item => item.state);
  }

}
