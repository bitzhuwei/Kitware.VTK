using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataSetGradient : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetGradient";

		public new static readonly string MRClassNameKey;

		static vtkDataSetGradient()
		{
			vtkDataSetGradient.MRClassNameKey = "class vtkDataSetGradient";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetGradient.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetGradient"));
		}

		public vtkDataSetGradient(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetGradient_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetGradient New()
		{
			vtkDataSetGradient result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetGradient.vtkDataSetGradient_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetGradient)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataSetGradient() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataSetGradient.vtkDataSetGradient_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetGradient_GetResultArrayName_01(HandleRef pThis);

		public virtual string GetResultArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkDataSetGradient.vtkDataSetGradient_GetResultArrayName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetGradient_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataSetGradient.vtkDataSetGradient_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetGradient_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataSetGradient.vtkDataSetGradient_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetGradient_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSetGradient NewInstance()
		{
			vtkDataSetGradient result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetGradient.vtkDataSetGradient_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetGradient)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetGradient_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetGradient SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetGradient vtkDataSetGradient = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetGradient.vtkDataSetGradient_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetGradient = (vtkDataSetGradient)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetGradient.Register(null);
				}
			}
			return vtkDataSetGradient;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDataSetGradient_SetResultArrayName_07(HandleRef pThis, string _arg);

		public virtual void SetResultArrayName(string _arg)
		{
			vtkDataSetGradient.vtkDataSetGradient_SetResultArrayName_07(base.GetCppThis(), _arg);
		}
	}
}
