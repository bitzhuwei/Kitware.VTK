using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDiscreteMarchingCubes : vtkMarchingCubes
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDiscreteMarchingCubes";

		public new static readonly string MRClassNameKey;

		static vtkDiscreteMarchingCubes()
		{
			vtkDiscreteMarchingCubes.MRClassNameKey = "class vtkDiscreteMarchingCubes";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDiscreteMarchingCubes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiscreteMarchingCubes"));
		}

		public vtkDiscreteMarchingCubes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDiscreteMarchingCubes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDiscreteMarchingCubes New()
		{
			vtkDiscreteMarchingCubes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiscreteMarchingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDiscreteMarchingCubes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDiscreteMarchingCubes_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDiscreteMarchingCubes_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDiscreteMarchingCubes_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDiscreteMarchingCubes NewInstance()
		{
			vtkDiscreteMarchingCubes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiscreteMarchingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDiscreteMarchingCubes_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDiscreteMarchingCubes SafeDownCast(vtkObjectBase o)
		{
			vtkDiscreteMarchingCubes vtkDiscreteMarchingCubes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDiscreteMarchingCubes = (vtkDiscreteMarchingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDiscreteMarchingCubes.Register(null);
				}
			}
			return vtkDiscreteMarchingCubes;
		}
	}
}
