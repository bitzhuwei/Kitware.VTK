using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWarpVector : vtkPointSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWarpVector";

		public new static readonly string MRClassNameKey;

		static vtkWarpVector()
		{
			vtkWarpVector.MRClassNameKey = "class vtkWarpVector";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWarpVector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWarpVector"));
		}

		public vtkWarpVector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpVector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWarpVector New()
		{
			vtkWarpVector result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWarpVector.vtkWarpVector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWarpVector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWarpVector.vtkWarpVector_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWarpVector_GetScaleFactor_01(HandleRef pThis);

		public virtual double GetScaleFactor()
		{
			return vtkWarpVector.vtkWarpVector_GetScaleFactor_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWarpVector_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWarpVector.vtkWarpVector_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWarpVector_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWarpVector.vtkWarpVector_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpVector_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWarpVector NewInstance()
		{
			vtkWarpVector result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWarpVector.vtkWarpVector_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpVector_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWarpVector SafeDownCast(vtkObjectBase o)
		{
			vtkWarpVector vtkWarpVector = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWarpVector.vtkWarpVector_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWarpVector = (vtkWarpVector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWarpVector.Register(null);
				}
			}
			return vtkWarpVector;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpVector_SetScaleFactor_07(HandleRef pThis, double _arg);

		public virtual void SetScaleFactor(double _arg)
		{
			vtkWarpVector.vtkWarpVector_SetScaleFactor_07(base.GetCppThis(), _arg);
		}
	}
}
