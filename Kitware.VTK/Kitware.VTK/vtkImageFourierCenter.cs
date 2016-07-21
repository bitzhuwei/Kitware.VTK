using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageFourierCenter : vtkImageDecomposeFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageFourierCenter";

		public new static readonly string MRClassNameKey;

		static vtkImageFourierCenter()
		{
			vtkImageFourierCenter.MRClassNameKey = "class vtkImageFourierCenter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageFourierCenter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageFourierCenter"));
		}

		public vtkImageFourierCenter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageFourierCenter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageFourierCenter New()
		{
			vtkImageFourierCenter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageFourierCenter.vtkImageFourierCenter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageFourierCenter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageFourierCenter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageFourierCenter.vtkImageFourierCenter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageFourierCenter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageFourierCenter.vtkImageFourierCenter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageFourierCenter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageFourierCenter.vtkImageFourierCenter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageFourierCenter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageFourierCenter NewInstance()
		{
			vtkImageFourierCenter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageFourierCenter.vtkImageFourierCenter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageFourierCenter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageFourierCenter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageFourierCenter SafeDownCast(vtkObjectBase o)
		{
			vtkImageFourierCenter vtkImageFourierCenter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageFourierCenter.vtkImageFourierCenter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageFourierCenter = (vtkImageFourierCenter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageFourierCenter.Register(null);
				}
			}
			return vtkImageFourierCenter;
		}
	}
}
