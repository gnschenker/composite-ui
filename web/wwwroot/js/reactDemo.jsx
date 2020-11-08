class HelloWorld extends React.Component {
    render() {
        return (
            <div className="helloWorld">
                Hello, {this.props.name} from React!
            </div>
        );
    }
}

ReactDOM.render(
    <HelloWorld name="Suzanne"/>, 
    document.getElementById('content')
);