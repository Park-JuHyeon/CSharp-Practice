class SuperObj {
    public void show(){
        print();
    }
    public void print(){
        print();        // 3. 오버라이딩으로 자식클래스의 print()함수가 출력
        System.out.print("Super");  // 4. super그대로 출력
    }
}

class SubObj extends SuperObj{
    public void show(){
        super.print();  // 2. SuperObj의 print()함수로 이동
    }
    public void print(){
        System.out.print("Sub");
    }
}

public class Soojebi {
    public static void main(String[] args){
        SuperObj s = new SubObj();
        s.show();   // 1. Subobj의 show함수로 이동
    }
}