using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkMoleculeReaderBase : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMoleculeReaderBase";

		public new static readonly string MRClassNameKey;

		static vtkMoleculeReaderBase()
		{
			vtkMoleculeReaderBase.MRClassNameKey = "class vtkMoleculeReaderBase";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMoleculeReaderBase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMoleculeReaderBase"));
		}

		public vtkMoleculeReaderBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMoleculeReaderBase_GetBScale_01(HandleRef pThis);

		public virtual double GetBScale()
		{
			return vtkMoleculeReaderBase.vtkMoleculeReaderBase_GetBScale_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMoleculeReaderBase_GetFileName_02(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkMoleculeReaderBase.vtkMoleculeReaderBase_GetFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMoleculeReaderBase_GetHBScale_03(HandleRef pThis);

		public virtual double GetHBScale()
		{
			return vtkMoleculeReaderBase.vtkMoleculeReaderBase_GetHBScale_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMoleculeReaderBase_GetNumberOfAtoms_04(HandleRef pThis);

		public virtual int GetNumberOfAtoms()
		{
			return vtkMoleculeReaderBase.vtkMoleculeReaderBase_GetNumberOfAtoms_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMoleculeReaderBase_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMoleculeReaderBase.vtkMoleculeReaderBase_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMoleculeReaderBase_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMoleculeReaderBase.vtkMoleculeReaderBase_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMoleculeReaderBase_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMoleculeReaderBase NewInstance()
		{
			vtkMoleculeReaderBase result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMoleculeReaderBase.vtkMoleculeReaderBase_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMoleculeReaderBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMoleculeReaderBase_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMoleculeReaderBase SafeDownCast(vtkObjectBase o)
		{
			vtkMoleculeReaderBase vtkMoleculeReaderBase = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMoleculeReaderBase.vtkMoleculeReaderBase_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMoleculeReaderBase = (vtkMoleculeReaderBase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMoleculeReaderBase.Register(null);
				}
			}
			return vtkMoleculeReaderBase;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMoleculeReaderBase_SetBScale_09(HandleRef pThis, double _arg);

		public virtual void SetBScale(double _arg)
		{
			vtkMoleculeReaderBase.vtkMoleculeReaderBase_SetBScale_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMoleculeReaderBase_SetFileName_10(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkMoleculeReaderBase.vtkMoleculeReaderBase_SetFileName_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMoleculeReaderBase_SetHBScale_11(HandleRef pThis, double _arg);

		public virtual void SetHBScale(double _arg)
		{
			vtkMoleculeReaderBase.vtkMoleculeReaderBase_SetHBScale_11(base.GetCppThis(), _arg);
		}
	}
}
