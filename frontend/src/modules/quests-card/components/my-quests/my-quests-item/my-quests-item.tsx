import { faArrowRight } from '@fortawesome/free-solid-svg-icons';
import { FC } from 'react';

import { IconButton } from '@/components';
import { IQuestDto } from '@/models/responses';

import styles from './my-quests-item.module.scss';

type MyQuestsItemProps = {
    quest: IQuestDto;
}

const MyQuestsItem: FC<MyQuestsItemProps> = ({ quest }) => {
    return (
        <div className={styles.itemWrapper}>
            <div className={styles.backgroundOverlay} />
            <div className={styles.itemInfo}>
                <p className={styles.title}>{quest.title}</p>

                <div>
                    <IconButton icon={faArrowRight} />
                </div>
            </div>
        </div>
    );
};

export { MyQuestsItem };
