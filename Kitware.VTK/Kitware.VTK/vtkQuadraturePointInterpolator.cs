using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkQuadraturePointInterpolator : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadraturePointInterpolator";

		public new static readonly string MRClassNameKey;

		static vtkQuadraturePointInterpolator()
		{
			vtkQuadraturePointInterpolator.MRClassNameKey = "class vtkQuadraturePointInterpolator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadraturePointInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadraturePointInterpolator"));
		}

		public vtkQuadraturePointInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadraturePointInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadraturePointInterpolator New()
		{
			vtkQuadraturePointInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadraturePointInterpolator.vtkQuadraturePointInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraturePointInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkQuadraturePointInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkQuadraturePointInterpolator.vtkQuadraturePointInterpolator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadraturePointInterpolator_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkQuadraturePointInterpolator.vtkQuadraturePointInterpolator_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadraturePointInterpolator_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkQuadraturePointInterpolator.vtkQuadraturePointInterpolator_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadraturePointInterpolator_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkQuadraturePointInterpolator NewInstance()
		{
			vtkQuadraturePointInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadraturePointInterpolator.vtkQuadraturePointInterpolator_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraturePointInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadraturePointInterpolator_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadraturePointInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkQuadraturePointInterpolator vtkQuadraturePointInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadraturePointInterpolator.vtkQuadraturePointInterpolator_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadraturePointInterpolator = (vtkQuadraturePointInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadraturePointInterpolator.Register(null);
				}
			}
			return vtkQuadraturePointInterpolator;
		}
	}
}
