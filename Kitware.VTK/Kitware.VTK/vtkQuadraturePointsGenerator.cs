using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkQuadraturePointsGenerator : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadraturePointsGenerator";

		public new static readonly string MRClassNameKey;

		static vtkQuadraturePointsGenerator()
		{
			vtkQuadraturePointsGenerator.MRClassNameKey = "class vtkQuadraturePointsGenerator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadraturePointsGenerator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadraturePointsGenerator"));
		}

		public vtkQuadraturePointsGenerator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadraturePointsGenerator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadraturePointsGenerator New()
		{
			vtkQuadraturePointsGenerator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadraturePointsGenerator.vtkQuadraturePointsGenerator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraturePointsGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkQuadraturePointsGenerator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkQuadraturePointsGenerator.vtkQuadraturePointsGenerator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadraturePointsGenerator_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkQuadraturePointsGenerator.vtkQuadraturePointsGenerator_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkQuadraturePointsGenerator_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkQuadraturePointsGenerator.vtkQuadraturePointsGenerator_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadraturePointsGenerator_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkQuadraturePointsGenerator NewInstance()
		{
			vtkQuadraturePointsGenerator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadraturePointsGenerator.vtkQuadraturePointsGenerator_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraturePointsGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadraturePointsGenerator_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadraturePointsGenerator SafeDownCast(vtkObjectBase o)
		{
			vtkQuadraturePointsGenerator vtkQuadraturePointsGenerator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadraturePointsGenerator.vtkQuadraturePointsGenerator_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadraturePointsGenerator = (vtkQuadraturePointsGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadraturePointsGenerator.Register(null);
				}
			}
			return vtkQuadraturePointsGenerator;
		}
	}
}
