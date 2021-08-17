import { VillageboardTemplatePage } from './app.po';

describe('Villageboard App', function() {
  let page: VillageboardTemplatePage;

  beforeEach(() => {
    page = new VillageboardTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
