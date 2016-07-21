using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataSetGradientPrecompute : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetGradientPrecompute";

		public new static readonly string MRClassNameKey;

		static vtkDataSetGradientPrecompute()
		{
			vtkDataSetGradientPrecompute.MRClassNameKey = "class vtkDataSetGradientPrecompute";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetGradientPrecompute.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetGradientPrecompute"));
		}

		public vtkDataSetGradientPrecompute(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetGradientPrecompute_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetGradientPrecompute New()
		{
			vtkDataSetGradientPrecompute result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetGradientPrecompute.vtkDataSetGradientPrecompute_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetGradientPrecompute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataSetGradientPrecompute() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataSetGradientPrecompute.vtkDataSetGradientPrecompute_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetGradientPrecompute_GradientPrecompute_01(HandleRef ds);

		public static int GradientPrecompute(vtkDataSet ds)
		{
			return vtkDataSetGradientPrecompute.vtkDataSetGradientPrecompute_GradientPrecompute_01((ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetGradientPrecompute_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataSetGradientPrecompute.vtkDataSetGradientPrecompute_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDataSetGradientPrecompute_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataSetGradientPrecompute.vtkDataSetGradientPrecompute_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetGradientPrecompute_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSetGradientPrecompute NewInstance()
		{
			vtkDataSetGradientPrecompute result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetGradientPrecompute.vtkDataSetGradientPrecompute_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetGradientPrecompute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetGradientPrecompute_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetGradientPrecompute SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetGradientPrecompute vtkDataSetGradientPrecompute = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetGradientPrecompute.vtkDataSetGradientPrecompute_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetGradientPrecompute = (vtkDataSetGradientPrecompute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetGradientPrecompute.Register(null);
				}
			}
			return vtkDataSetGradientPrecompute;
		}
	}
}
