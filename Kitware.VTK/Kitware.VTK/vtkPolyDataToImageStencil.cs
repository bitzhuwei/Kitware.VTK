using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolyDataToImageStencil : vtkImageStencilSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataToImageStencil";

		public new static readonly string MRClassNameKey;

		static vtkPolyDataToImageStencil()
		{
			vtkPolyDataToImageStencil.MRClassNameKey = "class vtkPolyDataToImageStencil";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataToImageStencil.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataToImageStencil"));
		}

		public vtkPolyDataToImageStencil(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataToImageStencil_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataToImageStencil New()
		{
			vtkPolyDataToImageStencil result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataToImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolyDataToImageStencil() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataToImageStencil_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkPolyDataToImageStencil_GetTolerance_02(HandleRef pThis);

		public virtual double GetTolerance()
		{
			return vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_GetTolerance_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkPolyDataToImageStencil_GetToleranceMaxValue_03(HandleRef pThis);

		public virtual double GetToleranceMaxValue()
		{
			return vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_GetToleranceMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkPolyDataToImageStencil_GetToleranceMinValue_04(HandleRef pThis);

		public virtual double GetToleranceMinValue()
		{
			return vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_GetToleranceMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPolyDataToImageStencil_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkPolyDataToImageStencil_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataToImageStencil_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyDataToImageStencil NewInstance()
		{
			vtkPolyDataToImageStencil result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataToImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataToImageStencil_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataToImageStencil SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataToImageStencil vtkPolyDataToImageStencil = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataToImageStencil = (vtkPolyDataToImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataToImageStencil.Register(null);
				}
			}
			return vtkPolyDataToImageStencil;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataToImageStencil_SetInput_10(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkPolyData arg0)
		{
			vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_SetInput_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkPolyDataToImageStencil_SetTolerance_11(HandleRef pThis, double _arg);

		public virtual void SetTolerance(double _arg)
		{
			vtkPolyDataToImageStencil.vtkPolyDataToImageStencil_SetTolerance_11(base.GetCppThis(), _arg);
		}
	}
}
