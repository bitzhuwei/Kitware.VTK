using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkClearZPass : vtkRenderPass
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkClearZPass";

		public new static readonly string MRClassNameKey;

		static vtkClearZPass()
		{
			vtkClearZPass.MRClassNameKey = "class vtkClearZPass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClearZPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClearZPass"));
		}

		public vtkClearZPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkClearZPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClearZPass New()
		{
			vtkClearZPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClearZPass.vtkClearZPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClearZPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkClearZPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkClearZPass.vtkClearZPass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkClearZPass_GetDepth_01(HandleRef pThis);

		public virtual double GetDepth()
		{
			return vtkClearZPass.vtkClearZPass_GetDepth_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkClearZPass_GetDepthMaxValue_02(HandleRef pThis);

		public virtual double GetDepthMaxValue()
		{
			return vtkClearZPass.vtkClearZPass_GetDepthMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkClearZPass_GetDepthMinValue_03(HandleRef pThis);

		public virtual double GetDepthMinValue()
		{
			return vtkClearZPass.vtkClearZPass_GetDepthMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkClearZPass_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkClearZPass.vtkClearZPass_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkClearZPass_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkClearZPass.vtkClearZPass_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkClearZPass_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkClearZPass NewInstance()
		{
			vtkClearZPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClearZPass.vtkClearZPass_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClearZPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkClearZPass_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClearZPass SafeDownCast(vtkObjectBase o)
		{
			vtkClearZPass vtkClearZPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClearZPass.vtkClearZPass_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClearZPass = (vtkClearZPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClearZPass.Register(null);
				}
			}
			return vtkClearZPass;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkClearZPass_SetDepth_09(HandleRef pThis, double _arg);

		public virtual void SetDepth(double _arg)
		{
			vtkClearZPass.vtkClearZPass_SetDepth_09(base.GetCppThis(), _arg);
		}
	}
}
