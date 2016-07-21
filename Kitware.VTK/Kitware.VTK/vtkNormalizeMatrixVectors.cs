using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkNormalizeMatrixVectors : vtkArrayDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkNormalizeMatrixVectors";

		public new static readonly string MRClassNameKey;

		static vtkNormalizeMatrixVectors()
		{
			vtkNormalizeMatrixVectors.MRClassNameKey = "class vtkNormalizeMatrixVectors";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNormalizeMatrixVectors.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNormalizeMatrixVectors"));
		}

		public vtkNormalizeMatrixVectors(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkNormalizeMatrixVectors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkNormalizeMatrixVectors New()
		{
			vtkNormalizeMatrixVectors result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNormalizeMatrixVectors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkNormalizeMatrixVectors() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkNormalizeMatrixVectors_GetVectorDimension_01(HandleRef pThis);

		public virtual int GetVectorDimension()
		{
			return vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_GetVectorDimension_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkNormalizeMatrixVectors_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkNormalizeMatrixVectors_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkNormalizeMatrixVectors_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkNormalizeMatrixVectors NewInstance()
		{
			vtkNormalizeMatrixVectors result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNormalizeMatrixVectors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkNormalizeMatrixVectors_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkNormalizeMatrixVectors SafeDownCast(vtkObjectBase o)
		{
			vtkNormalizeMatrixVectors vtkNormalizeMatrixVectors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNormalizeMatrixVectors = (vtkNormalizeMatrixVectors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNormalizeMatrixVectors.Register(null);
				}
			}
			return vtkNormalizeMatrixVectors;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkNormalizeMatrixVectors_SetVectorDimension_07(HandleRef pThis, int _arg);

		public virtual void SetVectorDimension(int _arg)
		{
			vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_SetVectorDimension_07(base.GetCppThis(), _arg);
		}
	}
}
