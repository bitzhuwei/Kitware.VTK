using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageConstantPad : vtkImagePadFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageConstantPad";

		public new static readonly string MRClassNameKey;

		static vtkImageConstantPad()
		{
			vtkImageConstantPad.MRClassNameKey = "class vtkImageConstantPad";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageConstantPad.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageConstantPad"));
		}

		public vtkImageConstantPad(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageConstantPad_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageConstantPad New()
		{
			vtkImageConstantPad result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageConstantPad.vtkImageConstantPad_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageConstantPad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageConstantPad() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageConstantPad.vtkImageConstantPad_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageConstantPad_GetConstant_01(HandleRef pThis);

		public virtual double GetConstant()
		{
			return vtkImageConstantPad.vtkImageConstantPad_GetConstant_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageConstantPad_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageConstantPad.vtkImageConstantPad_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageConstantPad_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageConstantPad.vtkImageConstantPad_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageConstantPad_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageConstantPad NewInstance()
		{
			vtkImageConstantPad result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageConstantPad.vtkImageConstantPad_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageConstantPad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageConstantPad_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageConstantPad SafeDownCast(vtkObjectBase o)
		{
			vtkImageConstantPad vtkImageConstantPad = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageConstantPad.vtkImageConstantPad_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageConstantPad = (vtkImageConstantPad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageConstantPad.Register(null);
				}
			}
			return vtkImageConstantPad;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConstantPad_SetConstant_07(HandleRef pThis, double _arg);

		public virtual void SetConstant(double _arg)
		{
			vtkImageConstantPad.vtkImageConstantPad_SetConstant_07(base.GetCppThis(), _arg);
		}
	}
}
