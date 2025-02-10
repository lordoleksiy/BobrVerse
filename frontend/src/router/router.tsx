import { createBrowserRouter } from 'react-router-dom';

import { AuthPage, MainPage, ProfilePage, TestPage } from '@/pages';
import { ProtectedRoute } from '@/router/protected-route.tsx';

export const router = createBrowserRouter([
    {
        element: <ProtectedRoute />,
        children: [
            {
                element: <MainPage />,
                children: [
                    {
                        path: '',
                        element: <ProfilePage />
                    }
                ]
            },
        ]
    },
    {
        path: 'test',
        element: <TestPage />
    },
    {
        path: 'auth',
        element: <AuthPage />,
    },
    {
        path: '*',
        element: <h1>Page is not found</h1>,
    }
]);
