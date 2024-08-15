import React from "react";
import style from './Botao.module.scss';

type BotaoProps = React.PropsWithChildren<{}>

class Botao extends React.Component<BotaoProps> {
    render() {
        return (
            <button className={style.botao}>
                {this.props.children}
            </button>
        )
    }
}

export default Botao