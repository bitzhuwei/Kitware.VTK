using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkUnstructuredGridVolumeRayCastFunction : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeRayCastFunction";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGridVolumeRayCastFunction()
		{
			vtkUnstructuredGridVolumeRayCastFunction.MRClassNameKey = "class vtkUnstructuredGridVolumeRayCastFunction";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridVolumeRayCastFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeRayCastFunction"));
		}

		public vtkUnstructuredGridVolumeRayCastFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastFunction_Finalize_01(HandleRef pThis);

		public virtual void FinalizeWrapper()
		{
			vtkUnstructuredGridVolumeRayCastFunction.vtkUnstructuredGridVolumeRayCastFunction_Finalize_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridVolumeRayCastFunction_Initialize_02(HandleRef pThis, HandleRef ren, HandleRef vol);

		public virtual void Initialize(vtkRenderer ren, vtkVolume vol)
		{
			vtkUnstructuredGridVolumeRayCastFunction.vtkUnstructuredGridVolumeRayCastFunction_Initialize_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeRayCastFunction_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGridVolumeRayCastFunction.vtkUnstructuredGridVolumeRayCastFunction_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridVolumeRayCastFunction_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridVolumeRayCastFunction.vtkUnstructuredGridVolumeRayCastFunction_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastFunction_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGridVolumeRayCastFunction NewInstance()
		{
			vtkUnstructuredGridVolumeRayCastFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastFunction.vtkUnstructuredGridVolumeRayCastFunction_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridVolumeRayCastFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastFunction_NewIterator_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkUnstructuredGridVolumeRayCastIterator NewIterator()
		{
			vtkUnstructuredGridVolumeRayCastIterator vtkUnstructuredGridVolumeRayCastIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastFunction.vtkUnstructuredGridVolumeRayCastFunction_NewIterator_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayCastIterator = (vtkUnstructuredGridVolumeRayCastIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayCastIterator.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayCastIterator;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastFunction_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridVolumeRayCastFunction SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridVolumeRayCastFunction vtkUnstructuredGridVolumeRayCastFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastFunction.vtkUnstructuredGridVolumeRayCastFunction_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayCastFunction = (vtkUnstructuredGridVolumeRayCastFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayCastFunction.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayCastFunction;
		}
	}
}
