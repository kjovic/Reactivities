import { observer } from 'mobx-react-lite';
import React from 'react';
import { Link } from 'react-router-dom';
import { Card, CardHeader, Icon, Image } from 'semantic-ui-react';
import { Profile } from '../../app/models/profile';


interface Props {
    profile: Profile;
}


export default observer (function ProfileCard({profile}: Props){
return (
    <Card as={Link} to={`/profile/${profile.username}`} > 
    <Image src={profile.image || '/assets/user.png'}/>
    <Card.Content>
        <CardHeader>{profile.displayName}</CardHeader>
        <Card.Description>Bio goes here</Card.Description>
    </Card.Content>
    <Card.Content extra >
        <Icon nam='user'/>
        20 followers
    </Card.Content>
    </Card>

)
    
})