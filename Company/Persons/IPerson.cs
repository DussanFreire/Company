using System;

namespace Company
{
    public interface IPerson
    {
        public string Gender { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public void PresentYourSelf();
    }
}