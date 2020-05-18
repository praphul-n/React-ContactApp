import React, { Component } from 'react';
import  ContactListFragment  from './components/ContactListFragment';

export default class App extends Component {
    static displayName = App.name;

    constructor(props) {
        super(props);
        this.state = { user: [] };
    }

    componentDidMount() {
        this.populateContactData();
    }

    static contactTable(user) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Username</th>
                        <th>Firstname</th>
                        <th>Lastname</th>
                        <th>DOB</th>
                        <th>Email</th>
                        <th>Phone</th>
                        <th>Mobile</th>
                    </tr>
                </thead>
                <tbody>
                    {user.map(user =>
                        <tr key={user.userName}>
                            <td>{user.userName}</td>
                            <td>{user.firstName}</td>
                            <td>{user.lastName}</td>
                            <td>{user.dob}</td>
                            <td>{user.email}</td>
                            <td>{user.phone}</td>
                            <td>{user.mobile}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }


    render() {
        let contents = this.state.loading
            ? <p><em>Loading.. Please wait...</em></p>
            : App.contactTable(this.state.user);

        return (
            <div>
                <div className="contact-list">
                    <h4 id="tabelLabel" >Contact List</h4>
                    <p><i>This component demonstrates fetching data from the server.</i></p>
                    {contents}
                </div>
                 
                <div className="contact-fragment">
                    <ContactListFragment/>
                </div>
            </div>
        );
    }

    async populateContactData() {
        await fetch('api/contact/contactdetails')
            .then(response => response.json())
            .then(data => {
                this.setState({ user: data });
            });
    }
}
