import { faG } from '@fortawesome/free-solid-svg-icons';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { useGoogleLogin } from '@react-oauth/google';
import { FC } from 'react';
import { useDispatch } from 'react-redux';
import { useNavigate } from 'react-router-dom';

import { ToastModeEnum } from '@/common';
import { BaseButton } from '@/components';
import { useToast } from '@/hooks';
import { IGoogleAuthRequestDto } from '@/models/requests';
import { useGoogleMutation, useLazyGetMyProfileQuery } from '@/services';
import { setProfile, setUrl } from '@/store/auth';

type AuthButtonProps = {}
const AuthButton: FC<AuthButtonProps> = () => {

    const [googleLogIn] = useGoogleMutation();
    const [fetchProfile] = useLazyGetMyProfileQuery();
    const navigate = useNavigate();
    const { addToast } = useToast();
    const dispatch = useDispatch();

    const onSuccess = (response: any): void => {
        const requestData: IGoogleAuthRequestDto = {
            accessToken: response.access_token
        };

        googleLogIn(requestData)
            .unwrap()
            .then(() => {
                navigate('/');
                fetchProfile()
                    .unwrap()
                    .then(profileData => {
                        dispatch(setProfile(profileData.data));
                        dispatch(setUrl(profileData.data));
                        navigate('/');
                    });
            })
            .catch((error) => { console.error('Failed to log in:', error); });
    };

    const onError = (): void => {
        addToast(ToastModeEnum.ERROR, 'Failed login with google');
    };

    const login = useGoogleLogin({ onSuccess, onError });

    return (
        <BaseButton onClick={login}>Login with google <FontAwesomeIcon icon={faG} /></BaseButton>
    );
};

export { AuthButton };
