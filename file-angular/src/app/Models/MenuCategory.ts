export class MenuCategory {
  menuCategory_Id: string;
  categoryName: string;
  state: boolean;

  constructor(menuCategory_Id: string, categoryName: string, state: boolean) {
    this.menuCategory_Id = menuCategory_Id;
    this.categoryName = categoryName;
    this.state = state;
  }
}
