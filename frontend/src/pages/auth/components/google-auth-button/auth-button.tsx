import { faG } from '@fortawesome/free-solid-svg-icons';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { useGoogleLogin } from '@react-oauth/google';
import { FC } from 'react';
import { useNavigate } from 'react-router-dom';

import { ToastModeEnum } from '@/common';
import { BaseButton } from '@/components';
import { useAuth, useToast } from '@/hooks';
import { IGoogleAuthRequestDto } from '@/models/requests';
import { useGoogleMutation } from '@/services';

type AuthButtonProps = {}
const AuthButton: FC<AuthButtonProps> = () => {

    const [googleLogIn] = useGoogleMutation();
    const navigate = useNavigate();
    const { logIn: setAuthenticated } = useAuth();
    const { addToast } = useToast();
    
    const onSuccess = (response: any): void => { 
        const requestData: IGoogleAuthRequestDto = {
            accessToken: response.access_token
        };

        googleLogIn(requestData)
            .unwrap()
            .then(() => {
                setAuthenticated();
                navigate('/');
            })
            .catch((error) => { console.error('Failed to log in:', error); });
    };

    const onError = (): void => {
        addToast(ToastModeEnum.ERROR, 'Failed login with google');
    };

    const login = useGoogleLogin({ onSuccess, onError });

    return (
        <BaseButton onClick={login}>Login with google <FontAwesomeIcon icon={faG}/></BaseButton>
    );
};

export { AuthButton };
