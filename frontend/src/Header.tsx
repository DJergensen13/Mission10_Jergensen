function Header(props: any) {
  return (
    <header className="row header navbar navbar-dark bg-dark justify-content-center">
      <div className="col-8 text-center">
        <div className="subtitle">
          <h1 className="text-white">{props.title}</h1>
          <p className="text-white">{props.description}</p>
        </div>
      </div>
    </header>
  );
}

export default Header;
