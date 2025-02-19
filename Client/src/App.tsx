const products = [
  {name: "product 1", price:1000},
  {name: "product 2", price:2000},
  {name: "product 3", price:3000}
];

function App() {
  return (
    <>
    <Header />
    <ProductList/>
    </>
  )
}

function Header(){
  return (
    <h1>Header</h1>
  );
}

function ProductList(){
  return (
    <div>
      <h2>ProductList</h2>
      <Product product={products[0]}/>
      <Product product={products[1]}/>
      <Product product={products[2]}/>
    </div>
  );
}

function Product(props: any) {
  return (
    <h3>{props.product.name} - {props.product.price}</h3>
  );
}
export default App
