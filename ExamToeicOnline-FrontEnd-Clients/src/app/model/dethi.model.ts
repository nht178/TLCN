export class DeThi {
  constructor(
    public id: string,
    public title: string,
    public duration: number
  ) { }
}


export interface ListDeThiResolved {
  listDeThis: DeThi[];
  error?: any;
}