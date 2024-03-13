import logo from './zTullisLogo2.png';

function Header(props: any) {
  return (
    <header className="row header navbar navbar-dark bg-black">
      <div className="col-4">
        <img src={logo} className="logo" alt="logo" />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">{props.title}</h1>
      </div>
    </header>
  );
}

export default Header;
