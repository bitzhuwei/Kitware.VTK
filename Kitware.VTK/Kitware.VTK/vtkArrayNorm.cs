using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkArrayNorm : vtkArrayDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayNorm";

		public new static readonly string MRClassNameKey;

		static vtkArrayNorm()
		{
			vtkArrayNorm.MRClassNameKey = "class vtkArrayNorm";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayNorm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayNorm"));
		}

		public vtkArrayNorm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayNorm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrayNorm New()
		{
			vtkArrayNorm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayNorm.vtkArrayNorm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayNorm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkArrayNorm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkArrayNorm.vtkArrayNorm_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkArrayNorm_GetDimension_01(HandleRef pThis);

		public virtual int GetDimension()
		{
			return vtkArrayNorm.vtkArrayNorm_GetDimension_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkArrayNorm_GetInvert_02(HandleRef pThis);

		public virtual int GetInvert()
		{
			return vtkArrayNorm.vtkArrayNorm_GetInvert_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkArrayNorm_GetL_03(HandleRef pThis);

		public virtual int GetL()
		{
			return vtkArrayNorm.vtkArrayNorm_GetL_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkArrayNorm_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkArrayNorm.vtkArrayNorm_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkArrayNorm_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkArrayNorm.vtkArrayNorm_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayNorm_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkArrayNorm NewInstance()
		{
			vtkArrayNorm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayNorm.vtkArrayNorm_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayNorm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayNorm_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrayNorm SafeDownCast(vtkObjectBase o)
		{
			vtkArrayNorm vtkArrayNorm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayNorm.vtkArrayNorm_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayNorm = (vtkArrayNorm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayNorm.Register(null);
				}
			}
			return vtkArrayNorm;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkArrayNorm_SetDimension_09(HandleRef pThis, int _arg);

		public virtual void SetDimension(int _arg)
		{
			vtkArrayNorm.vtkArrayNorm_SetDimension_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkArrayNorm_SetInvert_10(HandleRef pThis, int _arg);

		public virtual void SetInvert(int _arg)
		{
			vtkArrayNorm.vtkArrayNorm_SetInvert_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkArrayNorm_SetL_11(HandleRef pThis, int value);

		public void SetL(int value)
		{
			vtkArrayNorm.vtkArrayNorm_SetL_11(base.GetCppThis(), value);
		}
	}
}
