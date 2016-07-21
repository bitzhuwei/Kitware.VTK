using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSubdivideTetra : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSubdivideTetra";

		public new static readonly string MRClassNameKey;

		static vtkSubdivideTetra()
		{
			vtkSubdivideTetra.MRClassNameKey = "class vtkSubdivideTetra";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSubdivideTetra.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSubdivideTetra"));
		}

		public vtkSubdivideTetra(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSubdivideTetra_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSubdivideTetra New()
		{
			vtkSubdivideTetra result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSubdivideTetra.vtkSubdivideTetra_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubdivideTetra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSubdivideTetra() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSubdivideTetra.vtkSubdivideTetra_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSubdivideTetra_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSubdivideTetra.vtkSubdivideTetra_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSubdivideTetra_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSubdivideTetra.vtkSubdivideTetra_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSubdivideTetra_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSubdivideTetra NewInstance()
		{
			vtkSubdivideTetra result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSubdivideTetra.vtkSubdivideTetra_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubdivideTetra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSubdivideTetra_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSubdivideTetra SafeDownCast(vtkObjectBase o)
		{
			vtkSubdivideTetra vtkSubdivideTetra = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSubdivideTetra.vtkSubdivideTetra_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSubdivideTetra = (vtkSubdivideTetra)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSubdivideTetra.Register(null);
				}
			}
			return vtkSubdivideTetra;
		}
	}
}
