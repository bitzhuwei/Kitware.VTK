using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPlatonicSolidSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlatonicSolidSource";

		public new static readonly string MRClassNameKey;

		static vtkPlatonicSolidSource()
		{
			vtkPlatonicSolidSource.MRClassNameKey = "class vtkPlatonicSolidSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlatonicSolidSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlatonicSolidSource"));
		}

		public vtkPlatonicSolidSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPlatonicSolidSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlatonicSolidSource New()
		{
			vtkPlatonicSolidSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlatonicSolidSource.vtkPlatonicSolidSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlatonicSolidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPlatonicSolidSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPlatonicSolidSource.vtkPlatonicSolidSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPlatonicSolidSource_GetSolidType_01(HandleRef pThis);

		public virtual int GetSolidType()
		{
			return vtkPlatonicSolidSource.vtkPlatonicSolidSource_GetSolidType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPlatonicSolidSource_GetSolidTypeMaxValue_02(HandleRef pThis);

		public virtual int GetSolidTypeMaxValue()
		{
			return vtkPlatonicSolidSource.vtkPlatonicSolidSource_GetSolidTypeMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPlatonicSolidSource_GetSolidTypeMinValue_03(HandleRef pThis);

		public virtual int GetSolidTypeMinValue()
		{
			return vtkPlatonicSolidSource.vtkPlatonicSolidSource_GetSolidTypeMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPlatonicSolidSource_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPlatonicSolidSource.vtkPlatonicSolidSource_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPlatonicSolidSource_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPlatonicSolidSource.vtkPlatonicSolidSource_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPlatonicSolidSource_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPlatonicSolidSource NewInstance()
		{
			vtkPlatonicSolidSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlatonicSolidSource.vtkPlatonicSolidSource_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlatonicSolidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPlatonicSolidSource_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlatonicSolidSource SafeDownCast(vtkObjectBase o)
		{
			vtkPlatonicSolidSource vtkPlatonicSolidSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlatonicSolidSource.vtkPlatonicSolidSource_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlatonicSolidSource = (vtkPlatonicSolidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlatonicSolidSource.Register(null);
				}
			}
			return vtkPlatonicSolidSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlatonicSolidSource_SetSolidType_09(HandleRef pThis, int _arg);

		public virtual void SetSolidType(int _arg)
		{
			vtkPlatonicSolidSource.vtkPlatonicSolidSource_SetSolidType_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlatonicSolidSource_SetSolidTypeToCube_10(HandleRef pThis);

		public void SetSolidTypeToCube()
		{
			vtkPlatonicSolidSource.vtkPlatonicSolidSource_SetSolidTypeToCube_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlatonicSolidSource_SetSolidTypeToDodecahedron_11(HandleRef pThis);

		public void SetSolidTypeToDodecahedron()
		{
			vtkPlatonicSolidSource.vtkPlatonicSolidSource_SetSolidTypeToDodecahedron_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlatonicSolidSource_SetSolidTypeToIcosahedron_12(HandleRef pThis);

		public void SetSolidTypeToIcosahedron()
		{
			vtkPlatonicSolidSource.vtkPlatonicSolidSource_SetSolidTypeToIcosahedron_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlatonicSolidSource_SetSolidTypeToOctahedron_13(HandleRef pThis);

		public void SetSolidTypeToOctahedron()
		{
			vtkPlatonicSolidSource.vtkPlatonicSolidSource_SetSolidTypeToOctahedron_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPlatonicSolidSource_SetSolidTypeToTetrahedron_14(HandleRef pThis);

		public void SetSolidTypeToTetrahedron()
		{
			vtkPlatonicSolidSource.vtkPlatonicSolidSource_SetSolidTypeToTetrahedron_14(base.GetCppThis());
		}
	}
}
