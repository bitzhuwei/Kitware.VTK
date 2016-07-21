using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTriangularTCoords : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTriangularTCoords";

		public new static readonly string MRClassNameKey;

		static vtkTriangularTCoords()
		{
			vtkTriangularTCoords.MRClassNameKey = "class vtkTriangularTCoords";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTriangularTCoords.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriangularTCoords"));
		}

		public vtkTriangularTCoords(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTriangularTCoords_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTriangularTCoords New()
		{
			vtkTriangularTCoords result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriangularTCoords.vtkTriangularTCoords_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangularTCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTriangularTCoords() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTriangularTCoords.vtkTriangularTCoords_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTriangularTCoords_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTriangularTCoords.vtkTriangularTCoords_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTriangularTCoords_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTriangularTCoords.vtkTriangularTCoords_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTriangularTCoords_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTriangularTCoords NewInstance()
		{
			vtkTriangularTCoords result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriangularTCoords.vtkTriangularTCoords_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangularTCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTriangularTCoords_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTriangularTCoords SafeDownCast(vtkObjectBase o)
		{
			vtkTriangularTCoords vtkTriangularTCoords = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriangularTCoords.vtkTriangularTCoords_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTriangularTCoords = (vtkTriangularTCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTriangularTCoords.Register(null);
				}
			}
			return vtkTriangularTCoords;
		}
	}
}
