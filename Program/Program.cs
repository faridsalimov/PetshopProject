using PetShop;

Cat c = new("Graf", 5, "Male", 12, 50, 20);
Cat c1 = new("Prince", 7, "Female", 10, 40, 30);

c.Play();
c.Sleep();
c.Eat();

c1.Play();
c1.Sleep();

CatHouse house = new();
house.AddCat(c);
house.AddCat(c1);

house.ShowCats();