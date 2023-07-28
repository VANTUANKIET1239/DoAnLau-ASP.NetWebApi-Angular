export class Menu {
  menu_Id: string;
  menuName: string;
  menuImage: string;
  price: number;
  hotDeal: boolean;
  bestSaller: boolean;
  state: boolean;

  constructor(
    menu_Id: string,
    menuName: string,
    menuImage: string,
    price: number,
    hotDeal: boolean,
    bestSaller: boolean,
    state: boolean
  ) {
    this.menu_Id = menu_Id;
    this.menuName = menuName;
    this.menuImage = menuImage;
    this.price = price;
    this.hotDeal = hotDeal;
    this.bestSaller = bestSaller;
    this.state = state;
  }
}
